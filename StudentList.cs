// Name: Ibrahim Faisal Ibrahim Emara
// Student ID: 225105437

namespace Cse111Task1
{
    public class StudentList
    {
        public Student? First { get; set; }
        public Student? Last { get; set; }
        public int Count { get; private set; }

        public StudentList()
        {
            Count = 0;
            First = Last = null;
        }

        public void AddFront(int id)
        {
            Student newStudent = new Student(id);

            newStudent.Next = First;
            First = newStudent;

            if (Last == null)
            {
                Last = newStudent;
            }

            Count++;
        }

        public void AddEnd(int id)
        {
            Student newStudent = new Student(id);

            if (First == null)
            {
                First = Last = newStudent;
            }
            else
            {
                Last!.Next = newStudent;
                Last = newStudent;
            }

            Count++;
        }

        public bool Remove(int id)
        {
            Student? current = First;

            if (current == null)
                return false;

            if (current.Id == id)
            {
                First = current.Next;
                Count--;

                if (First == null)
                    Last = null;

                return true;
            }

            while (current.Next != null)
            {
                Student nextStudent = current.Next;

                if (nextStudent.Id == id)
                {
                    current.Next = nextStudent.Next;

                    if (Last == nextStudent)
                        Last = current;

                    Count--;
                    return true;
                }

                current = nextStudent;
            }

            return false;
        }

        public void Reverse()
        {
            Student? previous = null;
            Student? current = First;

            Last = First;

            while (current != null)
            {
                Student? nextStudent = current.Next;

                current.Next = previous;
                previous = current;
                current = nextStudent;
            }

            First = previous;
        }

        public void Print()
        {
            Student? current = First;

            while (current != null)
            {
                Console.Write(current.Id);

                current = current.Next;

                if (current != null)
                    Console.Write(" ");
            }

            Console.WriteLine();
        }
    }
}
