using System;
// Thomas Zundel
// IT112
// NOTES:
// BEHAVIORS NOT IMPLIMENTED AND WHY: i think i got it all 
namespace Zundel_Dialer
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone[] dialList = new Phone[10];

            dialList[0] = new HomePhone("CompuTest","(303) 985 - 5060", "1");
            dialList[1] = new CellPhone("Curtis Manufacturing","(603) 532 - 4123","2");
            dialList[2] = new HomePhone("Data Functions", "(800) 876 - 2524", "1");
            dialList[3] = new HomePhone("Donnay Repair", "(708) 397 - 3330", "1");
            dialList[4] = new HomePhone("ErgoNomic Inc", "(360) 434 - 3894", "1");
            dialList[5] = new HomePhone("ErgoSource", "(800) 969 - 4374", "1");
            dialList[6] = new CellPhone("Fox Bay Industries", "(800) 874 - 8527","2");
            dialList[7] = new CellPhone("Glare - Guard", "(800) 545 - 6254", "2");
            dialList[8] = new CellPhone("Hazard Comm Specialists", "(407) 783 - 6641","2");
            dialList[9] = new CellPhone("Komfort Support", "(714) 472 - 4409", "2");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(dialList[i].Dial());
            }

        }
    }
}
