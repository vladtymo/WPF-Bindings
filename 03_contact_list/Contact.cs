namespace _03_contact_list
{
    public class Contact
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public bool IsMale { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
