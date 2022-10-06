public class Card{
    static int Main(int[] args){
        List<int> myList = new List<int>();
        myList.Add(0);
// GENERATE RANDOM NUMBER
        Random rnd = new Random();
        int num = rnd.Next(1,5);
        int last = myList.Last();
        myList.Add(num);
// CHECK TO SEE IF IN LIST & IF SO RUN LOOP
        while (num == last ){
            num = rnd.Next(1,14);
            }
        myList.Add(num);
        return num;
    }
}

