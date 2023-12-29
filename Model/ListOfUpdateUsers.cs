using System;

namespace ValueBlueAPI.Model
{
    public partial class ListOfUpdateUsers
    {
        public string Name { get; set; }
        public string Job { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        
    }
}
