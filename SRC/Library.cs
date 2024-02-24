namespace Library{
  class Library{
    
    private Book[]  CATALOGY = new Book[3];

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
      Book newTitle = new Book();
      for(int i = 0; i < CATALOGY.Length; i++){
        if(CATALOGY[i] == null){
          CATALOGY[i] = newTitle;
          break;
        }
      }
      ShowCatalogy();
    }

    //Handdler print
    private void ShowCatalogy(){
      foreach (var title in CATALOGY){
        if(title == null)//VALIDAÇÃO NECESSARIA PARA NÃO PUXAR REFERENCIA DE POSIÇÃO VAZIA NO VETOR
          break;
        title.ShowData();
        Console.ReadLine();
      }
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