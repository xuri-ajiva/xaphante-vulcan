using System;
using GlmSharp;

namespace vulcan_01.Render
{
    public class Camera
    {
        private float fov;
        private float znear, zfar;

        private void UpdateViewMatrix()
        {
            mat4 transM;

            var rotM = mat4.Rotate(glm.Radians(Rotation.x * (FlipY ? -1.0f : 1.0f)), new(1.0f, 0.0f, 0.0f));
            rotM *= mat4.Rotate(glm.Radians(Rotation.y), new(0.0f, 1.0f, 0.0f));
            rotM *= mat4.Rotate(glm.Radians(Rotation.z), new(0.0f, 0.0f, 1.0f));

            var translation = Position;
            if (FlipY)
            {
                translation.y *= -1.0f;
            }
            transM = mat4.Translate(translation);

            if (Type == CameraType.Firstperson)
            {
                matrices.view = rotM * transM;
            }
            else
            {
                matrices.view = transM * rotM;
            }

            ViewPos = new vec4(Position, 0.0f) * new vec4(-1.0f, 1.0f, -1.0f, 1.0f);

            Updated = true;
        }

        public enum CameraType { Lookat, Firstperson };

        public CameraType Type = CameraType.Lookat;
        public vec3 Rotation;
        public vec3 Position;
        public vec4 ViewPos;

        public float RotationSpeed = 1.0f;
        public float MovementSpeed = 1.0f;

        public bool Updated;
        public bool FlipY = false;

        public struct __matrices
        {
            public mat4 perspective;
            public mat4 view;
        };

        public __matrices matrices;
        public __keys keys;

        public class __keys

        {
            public bool left = false;
            public bool right = false;
            public bool up = false;
            public bool down = false;
        }

        public bool Moving()
        {
            return keys.left || keys.right || keys.up || keys.down;
        }

        public float GetNearClip()
        {
            return znear;
        }

        public
            float GetFarClip()
        {
            return zfar;
        }

        public void SetPerspective(float fov, float aspect, float znear, float zfar)
        {
            this.fov = fov;
            this.znear = znear;
            this.zfar = zfar;
            matrices.perspective = mat4.Perspective(glm.Radians(fov), aspect, znear, zfar);
            if (FlipY)
            {
                matrices.perspective[1, 1] *= -1.0f;
            }
        }

        public void UpdateAspectRatio(float aspect)
        {
            matrices.perspective = mat4.Perspective(glm.Radians(fov), aspect, znear, zfar);
            if (FlipY)
            {
                matrices.perspective[1, 1] *= -1.0f;
            }
        }

        public void SetPosition(vec3 position)
        {
            Position = position;
            UpdateViewMatrix();
        }

        public void SetRotation(vec3 rotation)
        {
            Rotation = rotation;
            UpdateViewMatrix();
        }

        public void Rotate(vec3 delta)
        {
            Rotation += delta;
            UpdateViewMatrix();
        }

        public void SetTranslation(vec3 translation)
        {
            Position = translation;
            UpdateViewMatrix();
        }

        public void Translate(vec3 delta)
        {
            Position += delta;
            UpdateViewMatrix();
        }

        public void SetRotationSpeed(float rotationSpeed)
        {
            RotationSpeed = rotationSpeed;
        }

        public void SetMovementSpeed(float movementSpeed)
        {
            MovementSpeed = movementSpeed;
        }

        public void Update(float deltaTime)
        {
            Updated = false;
            if (Type == CameraType.Firstperson)
            {
                if (Moving())
                {
                    float moveSpeed = deltaTime * MovementSpeed;

                    var camFront = CamFront;

                    if (keys.up)
                        Position += camFront * moveSpeed;
                    if (keys.down)
                        Position -= camFront * moveSpeed;
                    if (keys.left)
                        Position -= glm.Cross(camFront, vec3.UnitY).Normalized * moveSpeed;
                    if (keys.right)
                        Position += glm.Cross(camFront, vec3.UnitY).Normalized * moveSpeed;

                    UpdateViewMatrix();
                }
            }
        }

        private vec3 CamFront
        {
            get
            {
                vec3 camFront;
                camFront.x = -glm.Cos(glm.Radians(Rotation.x)) * glm.Sin(glm.Radians(Rotation.y));
                camFront.y = glm.Sin(glm.Radians(Rotation.x));
                camFront.z = glm.Cos(glm.Radians(Rotation.x)) * glm.Cos(glm.Radians(Rotation.y));
                camFront = camFront.Normalized;
                return camFront;
            }
        }

        // Update camera passing separate axis data (gamepad)
        // Returns true if view or position has been changed
        public bool UpdatePad(vec2 axisLeft, vec2 axisRight, float deltaTime)
        {
            bool retVal = false;

            if (Type == CameraType.Firstperson)
            {
                // Use the common console thumbstick layout		
                // Left = view, right = move

                const float deadZone = 0.0015f;
                const float range = 1.0f - deadZone;

                var camFront = CamFront;

                float moveSpeed = deltaTime * MovementSpeed * 2.0f;
                float rotSpeed = deltaTime * RotationSpeed * 50.0f;

                // Move
                if (MathF.Abs(axisLeft.y) > deadZone)
                {
                    float pos = (MathF.Abs(axisLeft.y) - deadZone) / range;
                    Position -= camFront * pos * ((axisLeft.y < 0.0f) ? -1.0f : 1.0f) * moveSpeed;
                    retVal = true;
                }
                if (MathF.Abs(axisLeft.x) > deadZone)
                {
                    float pos = (MathF.Abs(axisLeft.x) - deadZone) / range;
                    Position += glm.Cross(camFront, new vec3(0.0f, 1.0f, 0.0f)).Normalized * pos * ((axisLeft.x < 0.0f) ? -1.0f : 1.0f) * moveSpeed;
                    retVal = true;
                }

                // mat4.Rotate
                if (MathF.Abs(axisRight.x) > deadZone)
                {
                    float pos = (MathF.Abs(axisRight.x) - deadZone) / range;
                    Rotation.y += pos * ((axisRight.x < 0.0f) ? -1.0f : 1.0f) * rotSpeed;
                    retVal = true;
                }
                if (MathF.Abs(axisRight.y) > deadZone)
                {
                    float pos = (MathF.Abs(axisRight.y) - deadZone) / range;
                    Rotation.x -= pos * ((axisRight.y < 0.0f) ? -1.0f : 1.0f) * rotSpeed;
                    retVal = true;
                }
            }
            else
            {
                // todo: move code from example base class for look-at
            }

            if (retVal)
            {
                UpdateViewMatrix();
            }

            return retVal;
        }
    };
}
