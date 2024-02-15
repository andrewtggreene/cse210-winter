class VerseChooser{
    private int _userChoice;
    private List<string> _listOfScriptures = new List<string>{@"And if men 
    come unto me I will show unto them their weakness. I give unto men weakness that 
    they may be humble; and my grace is sufficient for all men that humble themselves 
    before me; for if they humble themselves before me, and have faith in me, then will 
    I make weak things become strong unto them.", @"And he said unto 
    me: Knowest thou the condescension of God? And I said unto him: I know that he 
    loveth his children; nevertheless, I do not know the meaning of all things.", 
    @"And he shall go forth, suffering pains and afflictions and 
    temptations of every kind; and this that the word might be fulfilled which saith 
    he will take upon him the pains and the sicknesses of his people. And he will take 
    upon him death, that he may loose the bands of death which bind his people; and he 
    will take upon him their infirmities, that his bowels may be filled with mercy, 
    according to the flesh, that he may know according to the flesh how to succor 
    his people according to their infirmities. Now the Spirit knoweth all things; 
    nevertheless the Son of God suffereth according to the flesh that he might take 
    upon him the sins of his people, that he might blot out their transgressions 
    according to the power of his deliverance; and now behold, this is the testimony 
    which is in me.", @"But behold, if ye will awake and arouse your faculties, 
    even to an experiment upon my words, and exercise a particle of faith, yea, 
    even if ye can no more than desire to believe, let this desire work in you, 
    even until ye believe in a manner that ye can give place for a portion of my words.", 
    @"Wherefore, whoso believeth in God might with surety hope for a better 
    world, yea, even a place at the right hand of God, which hope cometh of faith, 
    maketh an anchor to the souls of men, which would make them sure and steadfast, 
    always abounding in good works, being led to glorify God.", @"Behold, 
    I would exhort you that when ye shall read these things, if it be wisdom in God that
    ye should read them, that ye would remember how merciful the Lord hath been unto 
    the children of men, from the creation of Adam even down until the time that ye 
    shall receive these things, and ponder it in your hearts. And when ye shall receive 
    these things, I would exhort you that ye would ask God, the Eternal Father, in the 
    name of Christ, if these things are not true; and if ye shall ask with a sincere heart, 
    with real intent, having faith in Christ, he will manifest the truth of it unto you, 
    by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the 
    truth of all things.", @"For behold, my beloved brethren, I say 
    unto you that the Lord God worketh not in darkness. He doeth not anything save it 
    be for the benefit of the world; for he loveth the world, even that he layeth down 
    his own life that he may draw all men unto him. Wherefore, he commandeth none 
    that they shall not partake of his salvation."};
    private List<Reference> _listOfReferences = new List<Reference>(); 
    public VerseChooser(int choice){
        _userChoice = choice - 1;
        string ether = "Ether";
        string nephi1 = "1 Nephi";
        string alma = "Alma";
        string moroni = "Moroni";
        string nephi2 = "2 Nephi";
        Reference ether1227 = new Reference(ether, 12, 27);
        Reference nephi11 = new Reference(nephi1, 11, 16,17);
        Reference alma7 = new Reference(alma, 7, 11, 13);
        Reference alma32 = new Reference(alma, 32, 27);
        Reference ether124 = new Reference(ether, 12, 4);
        Reference moroni10 = new Reference(moroni, 10, 3, 5);
        Reference nephi26 = new Reference(nephi2, 26, 23, 24);                        
        _listOfReferences.Add(ether1227);
        _listOfReferences.Add(nephi11);
        _listOfReferences.Add(alma7);
        _listOfReferences.Add(alma32);
        _listOfReferences.Add(ether124);
        _listOfReferences.Add(moroni10);
        _listOfReferences.Add(nephi26);
    }
    public Scripture ChooseVerse(){
        Scripture scripture = new Scripture(_listOfReferences[_userChoice], _listOfScriptures[_userChoice]);
        return scripture;
    }

}