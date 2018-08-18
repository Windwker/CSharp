using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events2
{
    class Program
    {
        static void Main(string[] args)
        {
            var Perro = new Dog("Serena",8);
            
            AnimalHairDresser hairDresser = new AnimalHairDresser();
            MailService service = new MailService();
            SmsService smsService = new SmsService();
            hairDresser.AnimalHairDressed += service.OnAnimalHairDressed;
            hairDresser.AnimalHairDressed += smsService.OnAnimalHairDressed;

            hairDresser.HairDress(Perro);
        }
    }
}
