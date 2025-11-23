using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientTestManagerWinApp.ApplicationLayer.Models
{
    public class PagedResult<TResponse> : Result<List<TResponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);

        public static PagedResult<TResponse> Ok(List<TResponse> data, int pageNumber, int pageSize, int totalCount, string message = "")
        {
            return new PagedResult<TResponse>
            {
                Success = true,
                Data = data,
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalCount = totalCount,
                Message = message
            };
        }

        public static PagedResult<TResponse> Fail(string message)
        {
            return new PagedResult<TResponse>
            {
                Success = false,
                Message = message,
                Data = new List<TResponse>()
            };
        }
    }

}
