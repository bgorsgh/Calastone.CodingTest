Calastone Coding Assigment

Console app that takes a text file input and applies filters to remove words according to the following rules:

– filter out all the words that contains a vowel in the middle of the word – the centre 1 or 2 letters
   ("clean" middle is ‘e’, "what" middle is ‘ha’, "currently" middle is ‘e’ and should be filtered, "the", "rather"
   should not be)

– filter out words that have length less than 3

– filter out words that contains the letter ‘t’

The resulting filtered text is written to the console. 

The input text is split into words using the following regular expression: [^\p{L}']+

Apostrophes are considered part of the word but removed before the vowel and length rules are applied.