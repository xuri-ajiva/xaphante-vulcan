using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Collation;
using SharpVk.Generator.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Generation
{
    public class ConstantGenerator
        : IWorker
    {
        private readonly IEnumerable<ConstantDeclaration> constants;

        public ConstantGenerator(IEnumerable<ConstantDeclaration> constants)
        {
            this.constants = constants;
        }

        public void Execute(IServiceCollection services)
        {
            foreach (var constant in this.constants)
            {
                string type = null;

                if (char.IsLetter(constant.Value[0]))
                {
                    // Looks like some extension enums are used for type name
                    // mapping - not sure what this is supposed to do yet, so
                    // skip them for now.
                    Console.WriteLine($"Skipping constant {constant.VkName} with value {constant.Value}");
                    continue;
                }
                else if (constant.Value.StartsWith("\""))
                {
                    type = "string";
                }
                else
                {
                    string typeSuffix = new string(constant.Value.Reverse()
                                                        .TakeWhile(char.IsLetter)
                                                        .Reverse()
                                                        .ToArray());

                    switch (typeSuffix.ToLower())
                    {
                        case "f":
                            type = "float";
                            break;
                        case "u":
                            type = "uint";
                            break;
                        case "ul":
                            type = "ulong";
                            break;
                        default:
                            type = (constant.Name.StartsWith("Max") || constant.Name.EndsWith("Size")) ? "int" : "uint";
                            break;
                    }
                }

                services.AddSingleton(new ConstantDefinition
                {
                    ConstantGroup = "Constants",
                    Namespace = new string[] { },
                    Type = type,
                    Name = constant.Name,
                    Value = constant.Value
                });
            }
        }
    }
}
