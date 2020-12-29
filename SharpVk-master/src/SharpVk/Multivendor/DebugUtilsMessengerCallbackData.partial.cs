using SharpVk.Interop;

namespace SharpVk.Multivendor
{
    public partial struct DebugUtilsMessengerCallbackData
    {
        /// <summary>
        /// </summary>
        internal static unsafe DebugUtilsMessengerCallbackData MarshalFrom(Interop.Multivendor.DebugUtilsMessengerCallbackData* pointer)
        {
            var result = default(DebugUtilsMessengerCallbackData);
            result.Flags = pointer->Flags;
            result.MessageIdName = HeapUtil.MarshalStringFrom(pointer->MessageIdName);
            result.MessageIdNumber = pointer->MessageIdNumber;
            result.Message = HeapUtil.MarshalStringFrom(pointer->Message);

            if (pointer->QueueLabels == null)
            {
                result.QueueLabels = null;
            }
            else
            {
                result.QueueLabels = new DebugUtilsLabel[pointer->QueueLabelCount];
                for (var index = 0; index < (uint)result.QueueLabels.Length; index++) result.QueueLabels[index] = DebugUtilsLabel.MarshalFrom(&pointer->QueueLabels[index]);
            }

            if (pointer->CommandBufLabels == null)
            {
                result.CommandBufLabels = null;
            }
            else
            {
                result.CommandBufLabels = new DebugUtilsLabel[pointer->CommandBufLabelCount];
                for (var index = 0; index < (uint)result.CommandBufLabels.Length; index++) result.CommandBufLabels[index] = DebugUtilsLabel.MarshalFrom(&pointer->CommandBufLabels[index]);
            }

            if (pointer->Objects == null)
            {
                result.Objects = null;
            }
            else
            {
                result.Objects = new DebugUtilsObjectNameInfo[pointer->ObjectCount];
                for (var index = 0; index < (uint)result.Objects.Length; index++) result.Objects[index] = DebugUtilsObjectNameInfo.MarshalFrom(&pointer->Objects[index]);
            }

            return result;
        }
    }
}