using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Generation.Marshalling;
using SharpVk.Generator.Pipeline;

namespace SharpVk.Generator.Generation
{
    public class GenerationStage
        : IStage
    {
        public void Configure(IServiceCollection services)
        {
            services.AddSingleton<NameLookup>();
            services.AddSingleton<ParsedExpressionBuilder>();
            services.AddSingleton<ParsedExpressionTokenCheck>();
            services.AddSingleton<ParsedExpressionEqualityCheck>();
            services.AddSingleton<NamespaceMap>();
            services.AddSingleton<CommentGenerator>();

            services.AddSingleton<IMarshalValueRule, MarshalVoidPointerValue>();
            services.AddSingleton<IMarshalValueRule, MarshalDelegateValue>();
            services.AddSingleton<IMarshalValueRule, MarshalHandleValue>();
            services.AddSingleton<IMarshalValueRule, MarshalStructValue>();
            services.AddSingleton<IMarshalValueRule, MarshalPointerValue>();
            services.AddSingleton<IMarshalValueRule, MarshalSimpleValue>();

            services.AddSingleton<IMemberPatternRule, VerbInfoMemberPattern>();
            services.AddSingleton<IMemberPatternRule, FixedLengthMemberPattern>();
            services.AddSingleton<IMemberPatternRule, ArraySingularMemberPattern>();
            services.AddSingleton<IMemberPatternRule, ArrayMemberPattern>();
            services.AddSingleton<IMemberPatternRule, ArrayLenMemberPattern>();
            services.AddSingleton<IMemberPatternRule, FixedValueMemberPattern>();
            services.AddSingleton<IMemberPatternRule, NextExtensionMemberPattern>();
            services.AddSingleton<IMemberPatternRule, VersionMemberPattern>();
            services.AddSingleton<IMemberPatternRule, SimpleMemberPattern>();

            services.AddSingleton<IWorker, PInvokeGenerator>();
            services.AddSingleton<IWorker, StructGenerator>();
            services.AddSingleton<IWorker, EnumGenerator>();
            services.AddSingleton<IWorker, PrimitiveGenerator>();
            services.AddSingleton<IWorker, DelegateGenerator>();
            services.AddSingleton<IWorker, MarshalledStructGenerator>();
            services.AddSingleton<IWorker, HandleGenerator>();
            services.AddSingleton<HandleGenerator>();
            services.AddSingleton<IWorker, HandleExtensionsGenerator>();
            services.AddSingleton<IWorker, ConstantGenerator>();
            services.AddSingleton<IWorker, ExceptionGenerator>();
            services.AddSingleton<IWorker, ExtensionConstantGenerator>();
        }
    }
}
