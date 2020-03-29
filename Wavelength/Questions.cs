using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wavelength
{
    static class Questions
    {
        public static List<Question> Default = new List<Question>()
        {
            new Question("Szereted a tejet?", new string[] { "Igen", "Nem", "Talán" }),
            new Question("Ki szereti jobban a másikat?", new string[] { "%p1", "%p2" }),
            new Question("%pr szeret-e főzni?", new string[] { "Igen", "Nem" })
        };
    }
}
