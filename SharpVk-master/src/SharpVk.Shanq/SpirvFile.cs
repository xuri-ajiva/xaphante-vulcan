using System.Collections.Generic;
using System.Linq;
using SharpVk.Spirv;

namespace SharpVk.Shanq
{
    public class SpirvFile
    {
        private readonly Dictionary<int, List<StatementEntry>> entries = new Dictionary<int, List<StatementEntry>>();
        private int nextResultId = 1;

        public IEnumerable<StatementEntry> Entries
        {
            get
            {
                return entries.OrderBy(x => x.Key).SelectMany(x => x.Value);
            }
        }

        public ResultId GetNextResultId()
        {
            return nextResultId++;
        }

        public void AddHeaderStatement(Op op, params object[] operands)
        {
            AddHeaderStatement(null, op, operands);
        }

        public void AddHeaderStatement(ResultId? resultId, Op op, params object[] operands)
        {
            AddHeaderStatement(resultId, new SpirvStatement(op, operands));
        }

        public void AddHeaderStatement(ResultId? resultId, SpirvStatement statement)
        {
            GetEntryList(0).Add(new StatementEntry
            {
                ResultId = resultId,
                Statement = statement
            });
        }

        public void AddAnnotationStatement(Op op, params object[] operands)
        {
            AddAnnotationStatement(null, op, operands);
        }

        public void AddAnnotationStatement(ResultId? resultId, Op op, params object[] operands)
        {
            AddAnnotationStatement(resultId, new SpirvStatement(op, operands));
        }

        public void AddAnnotationStatement(ResultId? resultId, SpirvStatement statement)
        {
            GetEntryList(1).Add(new StatementEntry
            {
                ResultId = resultId,
                Statement = statement
            });
        }

        public void AddGlobalStatement(Op op, params object[] operands)
        {
            AddGlobalStatement(null, op, operands);
        }

        public void AddGlobalStatement(ResultId? resultId, Op op, params object[] operands)
        {
            AddGlobalStatement(resultId, new SpirvStatement(op, operands));
        }

        public void AddGlobalStatement(ResultId? resultId, SpirvStatement statement)
        {
            GetEntryList(2).Add(new StatementEntry
            {
                ResultId = resultId,
                Statement = statement
            });
        }

        public void AddFunctionStatement(Op op, params object[] operands)
        {
            AddFunctionStatement(null, op, operands);
        }

        public void AddFunctionStatement(ResultId? resultId, Op op, params object[] operands)
        {
            AddFunctionStatement(resultId, new SpirvStatement(op, operands));
        }

        public void AddFunctionStatement(ResultId? resultId, SpirvStatement statement)
        {
            GetEntryList(3).Add(new StatementEntry
            {
                ResultId = resultId,
                Statement = statement
            });
        }

        private List<StatementEntry> GetEntryList(int priority)
        {
            List<StatementEntry> result;

            if (!entries.TryGetValue(priority, out result))
            {
                result = new List<StatementEntry>();

                entries.Add(priority, result);
            }

            return result;
        }

        public struct StatementEntry
        {
            public ResultId? ResultId;
            public SpirvStatement Statement;
        }
    }
}