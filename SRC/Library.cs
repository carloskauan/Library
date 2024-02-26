using System.Drawing;

namespace Library{
  class Library{
    
    static private int SIZE_CATALOGY = 3;

    private Book[]  CATALOGY = new Book[SIZE_CATALOGY];
    private string[] TITLES_NAME = new string[SIZE_CATALOGY];

    public Library(){
      while(true){
        Console.Clear();
        ShowEntryOptions();
      }
    }

    private void ShowStaffOptions(){
      Console.Clear();
      System.Console.Write("Press:\n1\t-\tRegister title\n2\t-\tRemove title\n3\t-\tView Stock\n4\t-\tEdit Stock>>");
      switch(int.Parse(Console.ReadLine())){
          case 1:
            RegisterTitle();
            break;
          case 2:
            //Remove title
            break;
          case 3:
            //View Stock
            break;
          case 4:
            //Edit Sotck
            break;
          case 0:
            System.Environment.Exit(0);
            break;
          default:
            System.Console.WriteLine("Invalid Option");
            break;
      }
    }

    //Handler Catology
    private void RegisterTitle(){
      Book newTitle = new Book(TITLES_NAME);
      for(int i = 0; i < CATALOGY.Length; i++){
        if(Book.VerifyExistence(TITLES_NAME, newTitle)){
          System.Console.WriteLine("Book already registered/exist");
          Console.ReadLine();
          break;
        }
        if(CATALOGY[i] == null){
          CATALOGY[i] = newTitle;
          TITLES_NAME[i] = newTitle.GetName();
          break;
        }
      }
      ShowCatalogy();
    }
                   
    //Handdler print [bok1, , ]
    private void ShowCatalogy(){
      foreach (var title in CATALOGY){
        if(title == null)//VALIDAÇÃO NECESSARIA PARA NÃO PUXAR REFERENCIA DE POSIÇÃO VAZIA NO VETOR
          break;
        title.ShowData();
      }
      System.Console.WriteLine("Press any key to contunue...");
      Console.ReadLine();
    }
    private void ShowEntryOptions(){
      System.Console.WriteLine("Wellcome to CEOS BooKing");
      System.Console.Write("Press:\n1\t-\tIf you cliente\n2\t-\tIf you staff\n0\t-\tTo exit\n>>");
      switch(int.Parse(Console.ReadLine())){
          case 1:
            //Cliente oprations
            break;
          case 2:
            ShowStaffOptions();
            break;
          case 3:
            ShowCatalogy();
            break;
          case 0:
            System.Environment.Exit(0);
            break;
          default:
            System.Console.WriteLine("Invalid Option");
            break;
      }
    }
  }
}