
string [] Foo(string [] arr){
    string [] arrTemp = new string[arr.Length];
    int j=0;
    for (int i = 0; i < arr.Length; i++)
    {
         if (arr[i].Length <=3){
            arrTemp[j]=arr[i];
            j++;    
        }
    }
    return arrTemp;

}
string[] arr = {"1234", "156", "-2", "computer science"};

System.Console.WriteLine(String.Join(",", Foo(arr)));