using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Lists.Models
{
    public class SearchGroup : List<Search>
    {
        IEnumerable<Search> searches;
        public string Title { get; set; }

        public SearchGroup( IEnumerable<Search> searches):base(searches)
        {
            Title = "Recent Searches";
        }
    }
}
