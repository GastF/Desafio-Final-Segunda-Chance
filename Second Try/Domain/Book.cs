namespace Domain
{
    public class Book
    {
        public string name;
        public int codeISBN;
        public string author;
        private List<Copy> copies;

    
        public List<Copy> Copies { get => copies; set => copies = value; }



        //constructor
        public Book(string name, int codeISBN, string author)
        {
            this.name = name;
            this.codeISBN = codeISBN;
            this.author = author;
            this.copies = new List<Copy>();
        }

        #region Methods

        public void AddCopy(Copy copy)
        {
            copies.Add(copy);
        }


        public bool HasAvailableCopies()
        {
            foreach (Copy copy in copies)
            {
                if (copy.IsAvailable())
                {
                    return true;
                }
            }
            return false;
        }

        public Copy BorrowCopy()
        {
            foreach (Copy copy in copies)
            {
                if (copy.IsAvailable())
                {
                    copy.Borrow();
                    copies.Remove(copy);
                    return copy;
                }
            }
            return null;
        }


        public void ReturnedCopy(Copy copy)
        {
            copy.Return();
            copies.Add(copy);
        }
        #endregion
    }
}