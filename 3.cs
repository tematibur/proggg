using System;
 
class MainClass {
  public static void Main (string[] args) {
    string word1 = "hello";
    string word2 = "world";
    string result = "";
    
    foreach(char c in word1) {
      if(word2.IndexOf(c) == -1) {
        result += c;
      }
    }
    
    foreach(char c in word2) {
      if(word1.IndexOf(c) == -1) {
        result += c;
      }
    }
    
    Console.WriteLine(result);
  }
}
Якщо запустити цей код, то на консолі буде виведено результат, який містить лише ті літери, які зустрічаються у одному з двох слов. Наприклад, для слів "hello" і "world" результатом буде "he wrd".
