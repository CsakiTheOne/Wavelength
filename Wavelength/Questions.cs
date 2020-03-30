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
            // Easter-egg
            new Question("1 + 1 =", new string[] { "Kettő", "Három ;)" }),
            new Question("2 + 2 =", new string[] { "Ez nem is matekos játék!" }),
            // Igen / Nem
            new Question("Szereted a tejet?"),
            new Question("Szereted a pizzát?"),
            new Question("Van-e olyan dal, amiről eszedbe jut a párod?"),
            // Valaki
            new Question("%pr tud-e főzni?"),
            new Question("%pr szeretne híres lenni?"),
            // Egyik vagy másik
            new Question("Ki szereti jobban a másikat?", new string[] { "%p1", "%p2" }),
            new Question("Ki unja meg először a romantikus filmet?", new string[] { "%p1", "%p2" }),
            new Question("Ki az erősebb?", new string[] { "%p1", "%p2" }),
            new Question("Ki az okosabb?", new string[] { "%p1", "%p2" }),
            new Question("Ki csókolta meg a másikat először?", new string[] { "%p1", "%p2" }),
            new Question("Ki becézi többet a másikat?", new string[] { "%p1", "%p2" }),
            new Question("Ki szereti jobban az anyósát?", new string[] { "%p1", "%p2" }),
            new Question("Ki táncol jobban?", new string[] { "%p1", "%p2" }),
            new Question("Melyikőtök főz jobban?", new string[] { "%p1", "%p2" }),
            new Question("Melyikőtök tölt több időt a fürdőszobában?", new string[] { "%p1", "%p2" }),
            // Én, te, valami
            new Question("Ki a főnök?", new string[] { "%p1", "%p2", "Igyekszem egyenrangúak lenni" }),
            new Question("Ki akar hamarabb gyereket?", new string[] { "%p1", "%p2", "..." }),
            new Question("Ki az okosabb?", new string[] { "%p1", "%p2", "Nem én!" }),
            new Question("Ki mondta a másiknak először, hogy \"szeretlek\"?", new string[] { "%p1", "%p2", "Szeretlek!" }),
            // Kifejtős kérdések
            new Question("A pénz boldogít?", new string[] { "Igen", "Nem", "Csak annyi, hogy kényelmesen éljünk", "Jobb sírni egy Cabrio-ban, mint egy biciklin" }),
            new Question("Hol lenne egy tökéletes randi?", new string[] { "Mozi", "Étterem", "Cukrászda", "Otthon", "Park / Erdő", "Máshol" }),
            new Question("Mivel vidítanád föl a másikat?", new string[] { "Ölelés és puszi", "Csoki / Kaja", "Irány az ágy!", "Valami más" }),
            // Vagy - vagy
            new Question("Marvel vagy DC?", new string[] { "Marvel", "DC", "Egyik sem" }),
            new Question("Melyiket választanád?", new string[] { "Film / sorozat", "Könyv" }),
            new Question("McDonalds, KFC vagy Burger King?", new string[] { "McDonalds", "KFC", "Burger King", "Norbi Update" }),
            new Question("Rántott hús vagy pörkölt?", new string[] { "Rántott hús", "Pörkölt", "Egyik sem" }),
            new Question("PlayStation vagy X-Box?", new string[] { "PlayStation", "X-Box", "Nintendo Switch", "PC master race!" }),
        };
    }
}
