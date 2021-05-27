## 11. Write a string sinusoidally

We illustrate what it means to write a string in sinusoidal fashion by means of an example. The string "Hello_World!" written in sinusoidal fashion is

        e               _               l            
    H       l       o       W       r       d              (Here _ denotes a blank.)
                l               o               !  

Define the snake string of s to be the left-right top-to-bottom sequence in which characters appear when s is written in sinusoidal fashion. For example, the snake string string for "Hello_World!" is "e_lHloWrdlo!".

Write a program which takes as input a string s and returns the snake string of s.

>Hint: Try concrete examples, and look for periodicity.