# Calculator-with-C-Sharp
First calculator using C# and Windows Forms
Currently there exist 2 issues with the comma/period that seperates the digits and decimals:

1) If you press comma/period first without adding any digits, it will not assume there's a zero infront of it, thus resetting by itself.
2) This calculators will bug for languages/countries that uses comma instead of period. Initially it will work, but after the calculation it will bug. This is due that (at least tested on) windows 10, it will assume that systems language.
Languages which have been tested on with the bug is Danish and Romanian. More languages may be affected by this.

Else this is my first attempt on making an application with C# and first time using Windows Forms, and currently a beginner with the concept of Git and Github.

