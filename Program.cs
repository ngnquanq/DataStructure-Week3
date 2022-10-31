class SinhVien
{
    public string id;
    public string name;
    public float dtb;
}
class Program
{
    static int SeqSearch(int[] arr, int value)
    {
        for (int i = 0; i <= arr.Length; i++)
        {
            if (arr[i] == value)
            {
                return i;
            }
            else
            {
                continue;
            }
        }
        return -1;
    }
    static int RecuSearch(int[]arr, int from, int value)
    {
        if(arr.Length == 0)
        {
            return -1;
        }
        else
        {
            if (arr[from] == value)
            {
                return from;
            }
            else
            {
                return RecuSearch((int[])arr, from+1, value);
            }
        }
    }


    static int SenSearch(int[] A, int value)
    {
        int x = A[A.Length - 1];
        A[A.Length - 1] = value;
        int i = 0;
        while (A[i] != value)
        {
            i++;
        }
        if ((i < A.Length - 1) || (A[A.Length - 1] == value))
        {
            return i;
        }
        else
        {
            Console.WriteLine("Phan tu khong ton tai trong mang");
        }
        return -1;
    }
    static int BinSearch(int[] A, int T)
    {
        int lower = 0, upper = A.Length - 1, mid;
        while (lower <= upper)
        {
            mid = (lower + upper) / 2;
            if (A[mid] > T)
            {
                upper = mid - 1;
            }
            else if (A[mid] < T)
            {
                lower = mid + 1;
            }
            else
            {
                return mid;
            }
        }
        return -1;
    }
    static public void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, };
        int[] A = { 2, 3, 4, 5, 6 };
        Console.WriteLine("Su dung RecuSearch: ");
        Console.WriteLine(RecuSearch(arr, 0, 3));
        Console.WriteLine("Su dung SeqSearch: ");
        Console.WriteLine(SeqSearch(arr, 3));
        Console.WriteLine("Su dung SenSearch: ");
        Console.WriteLine(SenSearch(arr, 3));
        Console.WriteLine("Su dung BinSearch: ");
        Console.WriteLine(BinSearch(arr, 3));
        Console.Read();
        SinhVien st = new SinhVien();
        st.id = "SV01"; st.name = "Nguyen A"; st.dtb = 5.6f;
        SinhVien st1 = new SinhVien();
        st1.id = "SV02"; st1.name = "Nguyen B"; st1.dtb = 9.8f;
        SinhVien st2 = new SinhVien();
        st2.id = "SV03"; st2.name = "Nguyen C"; st2.dtb = 10.0f;

    }
}
