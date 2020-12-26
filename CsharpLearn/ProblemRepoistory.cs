using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsharpLearn
{
    class ProblemRepoistory
    {
        private SqlDbContext context;
        public ProblemRepoistory()
        {
            context = new SqlDbContext();
        }
        public IList<Problem> GetBy(IList<ProblemStatus> exclude, bool hasSummary, bool descByPublishTime)
        {
            IQueryable<Problem> problems = context.Problems;
            if (exclude != null)
            {
                problems = problems.GetStatus(exclude);
            }
            if (hasSummary)
            {
                problems = problems.GetHasReword();
            }
            problems.GetOrderByPublishTime(descByPublishTime);

            return problems.ToList();
        }
    }
    public static class Extension
    {
        public static IQueryable<Problem> GetStatus(this IQueryable<Problem> problems, IList<ProblemStatus> exclude)
        {
            foreach (var item in exclude)
            {
                problems = problems.Where(p => p.Status != item);
            }
            return problems;
            //return problems.Where(p => !exclude.Contains(p.Status));
        }
        public static IQueryable<Problem> GetHasReword(this IQueryable<Problem> problems)
        {
            return problems.Where(p => p.Reward > 0);
        }
        public static IQueryable<Problem> GetOrderByPublishTime(this IQueryable<Problem> problems, bool desc = true)
        {
            if (desc)
            {
                return problems.OrderBy(p => p.PublishTime);
            }
            else
            {
                return problems.OrderByDescending(p => p.PublishTime);
            }
        }
    }
}
