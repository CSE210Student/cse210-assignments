using System;

class Program
{
    static void Main(string[] args)
    {
        Reference r = new Reference("1 Nephi", 11, 2, 5);
        Scripture s = new Scripture(r, "And the Spirit said unto me: Behold, what desirest thou? And I said: I desire to behold the things which my father saw. And the Spirit said unto me: Believest thou that thy father saw the tree of which he hath spoken? And I said: Yea, thou knowest that I believe all the words of my father.");

    }
}