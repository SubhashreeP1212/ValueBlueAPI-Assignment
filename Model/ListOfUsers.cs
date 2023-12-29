using System;
using System.Collections.Generic;

namespace ValueBlueAPI.Model
{
    public partial class ListOfUsers
    {
        public long Page { get; set; }
        public long PerPage { get; set; }
        public long Total { get; set; }
        public long TotalPages { get; set; }
        public List<Data> Data { get; set; }
        public Support Support { get; set; }
    }

        public partial class Data
        {
            public long Id { get; set; }
            public String Email { get; set; }
            public String First_Name { get; set; }
            public String Last_Name { get; set; }
            public Uri Avatar { get; set; }
        }

        public partial class Support
        {
            public Uri Url { get; set; }
            public String Text { get; set; }
        }
    
}
