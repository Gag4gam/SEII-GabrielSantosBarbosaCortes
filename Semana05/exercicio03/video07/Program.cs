
    class Program{

        static void Main(){
            for (int i = 0; i < 8; i++)
            {
                var thread = new Thread(escrever);
            thread.Start(i);
            }
            
            
        }

    
    static void escrever(){

        System.Console.WriteLine("Hello World");
    }


}
