using System.Linq;
using System.Linq.Expressions;
using Remotion.Linq;
using Remotion.Linq.Parsing.Structure;

namespace SharpVk.Shanq
{
    internal class ShanqQueryable<T>
        : QueryableBase<T>, IShanqQueryable
    {
        private ShanqQueryExecutor executor;

        public ShanqQueryable(IQueryProvider provider, Expression expression)
            : base(provider, expression)
        {
            executor = (ShanqQueryExecutor)((QueryProviderBase)provider).Executor;
        }

        public ShanqQueryable(QueryableOrigin origin, IQueryParser queryParser, IQueryExecutor executor, int binding = 0, int descriptorSet = 0)
            : base(new DefaultQueryProvider(typeof(ShanqQueryable<>), queryParser, executor))
        {
            Origin = origin;
            Binding = binding;
            DescriptorSet = descriptorSet;
            this.executor = (ShanqQueryExecutor)executor;
        }

        public QueryableOrigin Origin
        {
            get;
        }

        public int Binding
        {
            get;
        }

        public int DescriptorSet
        {
            get;
        }
    }

    internal interface IShanqQueryable
    {
        QueryableOrigin Origin
        {
            get;
        }

        int Binding
        {
            get;
        }

        int DescriptorSet
        {
            get;
        }
    }
}