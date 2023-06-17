using CPHelper.Requests;
using CPHelper.Responses;

namespace CPHelper.Managers
{
    public interface IOutputGenManager
    {
        Task<INTArrResponse> TwoSum(INTArrINTRequest request);
    }
}
