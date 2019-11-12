
# ΓΡΑΦΙΚΑ ΥΠΟΛΟΓΙΣΤΩΝ ΚΑΙ

# ΣΥΣΤΗΜΑΤΑ ΑΛΛΗΛΕΠΙΔΡΑΣΗΣ

Μούρτος Ηλίας

------------------------------------------------------------------------------------------------


## ΠΡΟΓΡΑΜΜΑΤΙΣΤΙΚΗ ΑΣΚΗΣΗ 2

**Scripts :
initializeGame(component του GameMenu):** ​Το κύριο script που
διαχειρίζεται το πρόγραμμα.Σε αυτό το script δημιουργώ το αρχικό
menu στο οποιο ο παιχτης διαλέγει τις διαστάσεις που θέλει και
ύστερα πατάει το button : PLAY και έτσι δημιουργώ τα cubes με τα
οποία δημιουργείται το ​3Δ πλέγμα (Χ, Υ, Ζ) διαστάσεων ΝxNxN.
**changeCube(component του FirstPersonCharacter) :** ​Με αυτό
το script αλλάζω το χρώμα στα cubes .Τα cubes έχουν tag
ανάλογα το χρώμα τους (“Yellow” για το κίτρινο) και πατωντας το
πληκτρο Ε κάνω raycast και αλλάζω το χρώμα (εκτός από το μπλε
και το magenda.
**fallCheck(component του κύβου fall):** ​Με αυτό το script ελέγχω
αν ο παίχτης έπεσε και τον επαναφέρω στην αρχική θέση ( στο Υ
του magenda).Αυτό πραγματοποιείται βάζοντας έναν collider σε
έναν κυβο (fall ) τοποθετημένο για y = -15.
**kickCubes(component του FirstPersonCharacter):** ​Με αυτό το
script κλωτσώ το καβάκι που έχω μπροστά μου.Αυτό
πραγματοποιείται κάνοντας raycast ώστε να βρίσκω τον κύβο που
έχω μπροστά μου και με ελέγχους της θέσης του player σε
συνδυασμό με την θέση του κύβου και ύστερα κάνω transform τον
κύβο μου στην επόμενη θέση .Στην περίπτωση που το transform
πρόσκειται να γίνει πάνω στο πλέγμα κάνω destroy τον κύβο
**createCubes(component του FirstPersonCharacter):** ​Με αυτό το
script δημιουργώ έναν κύβο πατώντας το αριστερό κλικ .Η
λειτουργία αυτή πραγματοποιείται επίσης με raycast.
destroyCubes(component του FirstPersonCharacter): ​Με αυτό
το script καταστρέφω τον κύβο όταν πατάω το πλήκτρο Q ,
κάνοντας raycast και καταστρέφοντας το κυβάκι που κάνω hit.
layerCheck(component του FirstPersonCharacter): ​Με αυτό το
script ελέγχω σε ποιο επιπεδο βρίσκεται ο player και προσθέτει 5
πόντους αν αναβαίνει επίπεδο η αφαιρει 5 αν πέφτει επίπεδο
topCheck(component του κύβου topCheck): ​Με αυτό το script
ελέγχω αν ο παίχτης φτάνει στο επίπεδο Ν .και ​παίρνει μία ζωή και
100 βαθμούς .Αυτή η λειτουργία πραγματοποιείται με collider
τοποθετώντας έναν κύβο στο ύψος Ν.

**Prefabs :**
BlueCube:κύβος με διαστάσεις 1χ1χ1 με χρώμα μπλε.
GreenCube:κύβος με διαστάσεις 1χ1χ1 με χρώμα πράσινο
RedCube:κύβος με διαστάσεις 1χ1χ1 με χρώμα κόκκινο
YellowCube:κύβος με διαστάσεις 1χ1χ1 με χρώμα μπλε.
MagendaCube:κύβος με διαστάσεις 1χ1χ1 με χρώμα μαντζεντα.
topCheck:κύβος με διαστάσεις Νχ0.5χΝ για τον ελεγχο του αν ο
παιχτης φτασει το ύψος Ν.
fall:κύβος με διαστάσεις (2 χ N)χ1χ (2 χN) για τον ελεγχο του αν ο
παίχτης πέσει στο κενο.
Wall:κύβος με διαστάσεις (Ν+1)χΝχ1 και Νχ1χ(Ν+1).
Spotlight:έτοιμο της unity.
fpscontroller:έτοιμο της unity.

**Σημειώσεις :**
Έχω βάλει σαν έξτρα λειτουργία όταν ο παίχτης χάσει να
“παγώνει” η κίνηση και να βγαίνει μήνυμα “GAME OVER”.
Έχω προσθέσει ήχους στην επαναφορά του παίχτη μετά από
πτώση ,όταν ο παίχτης κλωτσάει τον κύβο, στην αλλαγή του
χρώματος του κύβου , στην δημιουργία του κύβου , στην
καταστροφή του κύβου , όταν ο παίχτης φτάνει στο Ν και κερδίζει
πόντους και τέλος όταν ο παίχτης χάσει.
