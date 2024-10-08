namespace Library
{
    class Member
    {
        // Variable declares
        private int memberId;
        private string name;
        private string address;
        private int phone;

        // Public properties
        public int MemberId
        {
            get { return memberId; } // get method
            private set { memberId = value; } // Private setter makes it read-only
        }
        public string Name
        {
            get { return name; }
            set { name = value; } // set method
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        // Constructor for new member
        public Member(int memberId, string name, string address, int phone)
        {
            this.memberId = memberId;
            this.name = name;
            this.address = address;
            this.phone = phone;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {memberId}");
            Console.WriteLine($"Member Name: {name}");
            Console.WriteLine($"Member Address: {address}");
            Console.WriteLine($"Member Phone no: {phone}");
            Console.WriteLine();
        }
    }
}