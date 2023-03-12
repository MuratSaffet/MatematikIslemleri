namespace OrtakYapilar
{
    public static class Aciklamalar
    {
        public const string ebobUygulamasi = @"Ebob, ""En Büyük Ortak Bölen"" kısaltmasıdır ve matematikte iki ya da daha fazla sayının ortak bölenleri arasından en büyüğünü ifade eder.

1. yöntemde ebob hesaplamak için asal çarpanları metodu kullanılmıştır. Bu yöntemde, sayılar asal çarpanlarına ayrılır ve ortak olan tüm asal çarpanlarının çarpımı, ebobu verir.

2. yöntemde ebob hesaplamak için Öklid yöntemi kullanılmıştır. Bu yöntem, özyinemeli(recursive) yaklaşımla kodlanmmıştır. Öklid yönteminde iki sayı büyükten küçüğe doğru sıralanır ve ardından sayılar biribirine bölünerek kalan hesaplanır. Eğer kalan sıfır ise küçük sayı ebob olarak kabul edilir. Eğer kalan sıfır değilse bölüm yerine küçük olan sayı, bölen yerine de kalan sayı alınarak işlemler tekrarlanır.

3. yöntemde ebob hesaplamak için Öklid yöntemi kullanılmıştır. Bu yöntem, iteratif(iterative) yaklaşımla kodlanmmıştır. 
";

    }
}

