using System.Drawing;

namespace Library{
  class Library{
  
    static private int SIZE_CATALOGY = 3;

    private Book[] CATALOGIES = new Book[SIZE_CATALOGY];

    //Handler Catology
    public void RegisterTitle(Book? book) { 
    
      if (book == null || VerifyExistence(book.NAME)){
        System.Console.WriteLine("The Book already registered/exist");
        Console.ReadLine();
      } else {
        for(int i = 0; i < CATALOGIES.Length; i++){
          if(CATALOGIES[i] == null){
            CATALOGIES[i] = book;
            break;
          } 
        }
        ShowCatalogy();
      }
    }
                   
    //Handdler print [bok1, , ]
    public void ShowCatalogy(){
      foreach (var book in CATALOGIES){
        if(book == null)//VALIDAÇÃO NECESSARIA PARA NÃO PUXAR REFERENCIA DE POSIÇÃO VAZIA NO VETOR
          break;
        book.ShowData();
      }
      System.Console.WriteLine("Press any key to contunue...");
      Console.ReadLine();
    }

    public bool VerifyExistence(string name){
      foreach (var book in CATALOGIES){
        if(book == null)//VALIDAÇÃO NECESSARIA PARA NÃO PUXAR REFERENCIA DE POSIÇÃO VAZIA NO VETOR
          return false;

        if(book.NAME.Equals(name)){
          return true;
        }
      }
      return false;
    }
  }
}