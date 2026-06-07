public class DynamicArray {
    
    public int capacity;
    public int[] inArray;
    public int size;

    public DynamicArray(int capacity) {

        this.capacity = capacity;
        inArray = new int [capacity];
        size = 0;
    }

    public int Get(int i) {
        return inArray[i];
    }

    public void Set(int i, int n) {
        inArray[i] = n;
    }

    public void PushBack(int n) {

        if (size == capacity)
        {
            Resize();
        }

        inArray[size] = n;
        size ++;
    }

    public int PopBack() {
        int lastValue = inArray[size - 1];
        size --;
        return lastValue;
    }

    private void Resize() {
        capacity *= 2;
        Array.Resize(ref inArray, capacity);
    }

    public int GetSize() {
        return size;
    }

    public int GetCapacity() {
        return capacity;
    }
}
