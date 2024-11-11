
class MainClass{
    static int count;
    static void Main(){
        var thread1 = new Thread(incrementCount);
        var thread2 = new Thread(incrementCount);
        thread1.Start();
        Thread.Sleep(500);
        thread2.Start();
    }
    static void incrementCount(){

        while(true){
            count++;
            System.Console.WriteLine("threadid"+Thread.CurrentThread.ManagedThreadId+"count: "+count);
            Thread.Sleep(1000);
        }
    }
}