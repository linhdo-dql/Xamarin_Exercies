using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Lists.Models
{
    public class SearchService
    {
        /// <summary>
        /// Tạo 1 List các Search
        /// </summary>
        public ObservableCollection<Search> _searches;
        public IEnumerable<Search> GetSearch( string filter = null )
        {
            _searches = new ObservableCollection<Search>()
            {
                new Search(1,"Hồ Chí Minh",new DateTime(2016,9,1), new DateTime(2016,11,1)),
                new Search(2,"Hà Nội",new DateTime(2016,9,1), new DateTime(2016,11,1)),
                new Search(3,"Quảng Ninh",new DateTime(2016,9,1), new DateTime(2016,11,1))
            };
            if ( String.IsNullOrWhiteSpace(filter) )
            {
                return _searches;
            }
            return _searches.Where(s => s.Location.StartsWith(filter));
        }
        /// <summary>
        /// Hàm xóa 1 search trong danh sách bằng Id
        /// </summary>
        /// <param name="searchId"></param>
        public void DeleteSearch(int searchId)
        {
            int length = _searches.Count;
            for ( int i = 0 ; i < length ; i++ )
            {
                if ( _searches[i].Id == searchId )
                {
                    _searches.RemoveAt(i);
                    i--;
                    length--;
                }
            }
        }
    }
}
