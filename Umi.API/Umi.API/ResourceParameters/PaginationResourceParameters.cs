namespace Umi.API.ResourceParameters
{
    public class PaginationResourceParameters
    {
        private int _pageNumber = 1;
        private int _pageSize = 2;
        private const int maxPageSize = 50;

        public int PageNumber
        {
            get => _pageNumber;
            set
            {
                if (value >= 1)
                {
                    _pageNumber = value;
                }
            }
            
        }

        public int PageSize
        {
            get => _pageSize;
            set
            {
                if (value >= 1)
                {
                    _pageSize = (value >maxPageSize) ? maxPageSize : value;
                }
            }
        }

    }
}