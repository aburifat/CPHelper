using CPHelper.Requests;
using CPHelper.Responses;
using CPHelper.CodeBase;

namespace CPHelper.Managers
{
    public class OutputGenManager : IOutputGenManager
    {
        public async Task<INTArrResponse> TwoSum(INTArrINTRequest request)
        {
            int[] var1 = request.Var1;
            int var2 = request.Var2;
            var Solver = new _twosum();
            int[] res1 = Solver.Solution(var1,var2);
            INTArrResponse ans = new INTArrResponse();
            ans.Var1 = res1;
            return await Task.FromResult(ans);
        }
    }
}
