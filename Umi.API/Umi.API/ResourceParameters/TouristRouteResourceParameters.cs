using System;
using System.Text.RegularExpressions;

namespace Umi.API.ResourceParameters
{
    public class TouristRouteResourceParameters
    {
        // private int _pageNumber = 1;
        // private int _pageSize = 2;
        // private const int maxPageSize = 50;
        //
        // public int PageNumber
        // {
        //     get => _pageNumber;
        //     set
        //     {
        //         if (value >= 1)
        //         {
        //             _pageNumber = value;
        //         }
        //     }
        //     
        // }
        //
        // public int PageSize
        // {
        //     get => _pageSize;
        //     set
        //     {
        //         if (value >= 1)
        //         {
        //             _pageSize = (value >maxPageSize) ? maxPageSize : value;
        //         }
        //     }
        // }

        public string Keyword { get; set; }

        public string RatingOpt { get; set; }
        // nullable
        public int? RatingValue { get; set; }
        // private rating, not returnable do opt on it
        private string _rating { get; set; }

        public string Rating
        {
            get => _rating;
            set // built in receiving param value
            {
                // @"" -> C# string
                // 2 parts: largeThen + 9
                if (!string.IsNullOrWhiteSpace(value))
                {
                    Regex regex = new Regex(@"([A-Za-z0-9\-]+)(\d+)");
                    
                    // if value is null, error here, so need check if value null
                    Match match = regex.Match(value);
                    if (match.Success)
                    {
                        RatingOpt = match.Groups[1].Value;
                        RatingValue = Int32.Parse(match.Groups[2].Value);
                    }
                }

                _rating = value;
            }
        }
    }
}