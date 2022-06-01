using System.Collections.Generic;

namespace web3.Models
{
    public class Category
    {
        public string id { get; set; }
        public string name { get; set; }
        
        //OneToMany
        public ICollection<Mobile> Mobiles { get; set; }
    }
}
