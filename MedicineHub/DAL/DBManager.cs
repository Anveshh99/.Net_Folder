namespace DAL;
using BOL;
using System.Text.Json;
using System.Threading.Tasks;

public class DBManager
{
    List<Medicine> list=new List<Medicine>();

    public static List<Medicine> RetrieveMedicineData()
    {
         if(File.Exists(@"D:\DOT NET\Dot_Net_Practice\Net_Folder\day10\MOCK_DATA.json"))
         {
            string jsonString=File.ReadAllText(@"D:\DOT NET\Dot_Net_Practice\Net_Folder\day10\MOCK_DATA.json");
            List<Medicine> allMedicine=JsonSerializer.Deserialize<List<Medicine>>(jsonString);
            return allMedicine ;
         }
         else{
            return null;
         }
    }


}
