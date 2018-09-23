using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credits.Models
{
    public class ComboItem
    {
        public string Text { get; set; }
        public string Id { get; set; }

        public override string ToString()
        {
            return this.Text;
        }
    }
}
