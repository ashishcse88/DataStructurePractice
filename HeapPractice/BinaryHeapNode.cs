using System;
public class BinaryHeapNode
{
    int[] arr;
    int sizeOfHeap;
    public BinaryHeapNode(int size)
    {
        this.arr = new int[size];
        this.sizeOfHeap = 0;
    }

    public void Insert(int val)
    {
        this.sizeOfHeap++;
        int i = this.sizeOfHeap - 1;
        
        while(i > 0 && val > this.arr[(i - 1) / 2])
        {
            
                this.arr[i] = this.arr[(i - 1) / 2];
                i = (i - 1) / 2;
            
        }
        this.arr[i] = val;
    }

    public int GetLeftChid(int index)
    {
        int lc = index * 2 + 1;
        if (lc > this.sizeOfHeap - 1)
            return -1;
        return lc;
    }

    public int GetRightChild(int index)
    {
        int rc = index * 2+2;
        if (rc > this.sizeOfHeap - 1)
            return -1;
        return rc;
    }

    public int GetParent(int index)
    {
        int p = (index - 1) / 2;
        if (p < 0 || p > this.sizeOfHeap - 1)
            return -1;
        return p;
    }
    public void PrelocateDown(int index)
    {
        var lc = GetLeftChid(index);
        var rc = GetRightChild(index);
        int max = index;
        if (lc != -1 && arr[index] < arr[lc])
        {
            max = lc;
        }
        if (rc != -1 && arr[max] < arr[rc])
        {
            max = rc;
        }
        if (index != max)
        {
            var temp = arr[index];
            arr[index] = arr[max];
            arr[max] = temp;
            PrelocateDown(max);
        }
    }

    public int DeleteMax()
    {
        int retVal = arr[0];
        this.arr[0] = this.arr[sizeOfHeap - 1];
        this.sizeOfHeap--;
        PrelocateDown(0);
        return retVal;
    }
    public void PrintHeap()
    {
        Console.WriteLine("Printing Heap");
        for (int i = 0; i<= this.sizeOfHeap - 1; i++)
        {
            Console.WriteLine(this.arr[i]);
        }
    }
}