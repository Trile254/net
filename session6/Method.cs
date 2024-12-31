
class Method {

    /// <summary>
    /// Ham kiem tra so nguyen to
    /// </summary>
    /// <param name="number">number co kieu so nguyen duong</param>
    /// <returns>true: so nguyen to. false: khong la so nguyen to</return>
    public static bool checkPrime(int number) {
        if (number < 2){
            return false;
        }

        for(int i = 2; i <= Math.Sqrt(number); i++){
            if(number % i == 0){
                return false;
            }
        }
        return true;
    }

    public static void printSquareTriangle(int height){
        for(int i = 1; i <= height; i++) {
            for (int j = 1; j <= i; j++) {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    // public static void printRowTriangle(int row) {
    //     for(int i = 1; i <= row; i++){
    //         Console.Write("* ");
    //     }
    //     Console.WriteLine();
    // }
}