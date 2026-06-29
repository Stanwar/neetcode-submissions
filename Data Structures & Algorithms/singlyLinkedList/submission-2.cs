public class LinkedList {
    Node tail;
    Node head;
    int size;
    public LinkedList() {
        this.head = new Node(-1);
        this.tail = this.head;
    }

    public int Get(int index) {
        if (OutOfBounds(index)){
            return -1;
        }

        var currentNode = head.next;
        var position= 0;
        while(currentNode.next != null){
            if(index == position){
                break;
            }
            currentNode = currentNode.next;
            position++;
        }

        return currentNode.value;
    }

    public void InsertHead(int val) {
        var node = new Node(val);

        node.next = head.next;
        head.next = node;

        if (size == 0) {
            tail = node;
        }

        size++;
    }

    public void InsertTail(int val) {
        var node = new Node(val);
        node.next = null;
        tail.next = node;
        tail = node;
        size++;
    }

    public bool Remove(int index) {
        if (OutOfBounds(index)){
            return false;
        }
        // Removing head
        if (index == 0) {
            var firstNode = head.next;
            head.next = firstNode.next;
            // If list becomes empty
            if (head == null) {
                tail = null;
            }

            size--;
            return true;
        }

        var currentNode = head;
        var position = 0;

        while(position < index){
            currentNode = currentNode.next; 
            position++;
        }

        var nodeToRemove = currentNode.next;
        currentNode.next = nodeToRemove.next;

        if (nodeToRemove == tail){
            tail = currentNode;
        }


        size--;
        return true;
    }

    public List<int> GetValues() {
        var values = new List<int>();
        var current = head.next; // skip dummy

        while (current != null) {
            values.Add(current.value);
            current = current.next;
        }

        return values;
    }

    private bool OutOfBounds(int index){
        if (index < 0 || index >= size){
            return true;
        }

        return false;
    }
}

// Linked List Node class
public class Node {
    public Node next;
    public int value;

    public Node(int val){
        this.value = val;
    }
}