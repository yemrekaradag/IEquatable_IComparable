# IEquatable_IComparable

<h2>IEquatable</h2>
Since there are both a collection and an object from an entity of type T, I often encountered the IEquatable Interface because I could not get clear information about the existence or non-existence of the collection through the Contains method.

The IEquatable Interface is a construct that applies the Equals method to the inheritance class and makes our object comparison through this method.

We can compare according to property values or with a collection of object type.

<h2>IComparable</h2>

IComparable Interface makes the inheriting class implement the CompareTo method and provides comparison through this method.

We know that with the static Sort method of the Array class, we can sort the value-type data, that is, simple data types. However, when trying to sort reference type data, that is, objects, we cannot use the Array.Sort method because it does not know which property of the objects to sort by.

If you examine the Parts class, there is a Part type parameter named “other” that represents other objects in the CompareTo method. As a result of the control, a comparison is made between the current object and other objects according to a certain property, and the result of the comparison is returned as an int type value.

According to the result of the sorting algorithm in terms of .NET;

If it is a negative value, this object is smaller than the other object.
If equal to zero, this object and the other object are equal
If greater than zero, this object is larger than the other object
is in the form.

After this interface, we can perform sorting with the Array.Sort method.

<img alt="ss1" src="https://user-images.githubusercontent.com/107070882/213446440-fadb8763-5c78-4cb4-819e-83b33702e0fa.png">

-----------------------------------------------------------------------------------------------------------------------------------------------------------

# IEquatable_IComparable

<h2>IEquatable</h2>
T tipinden bir entity'den birer koleksiyon ve nesne olduğunu için genellikle elimdeki nesnenin, koleksiyonun Contains metodu aracılığıyla varlığı ya da yokluğu hakkında net bilgi alamadığım için IEquatable Interface’i ile karşılaştım.

IEquatable Interface’i, mirası sınıfa Equals metodunu uygulatan ve bu metod aracılığıyla nesne karşılaştırmamızı yaptıran bir yapıdır.

Property değerlerine göre ya da nesne tipinden bir koleksiyon ile karşılaştırma yapabiliriz.

<h2>IComparable</h2>

IComparable Interface’i, miras alan sınıfa CompareTo metodunu uygulatmakta ve bu metot aracılığıyla karşılaştırmayı sağlamaktadır.

Array sınıfının static Sort metodu ile elimizdeki değer tipli verileri yani basit veri tiplerini sıralanabileceğini biliyoruz. Ancak referans tipli verileri yani nesneleri sıralamaya çalışırken, nesnelerin hangi özelliğine göre sıralama yapacağını bilmediği için Array.Sort metodu kullanamıyoruz.

Parçalar sınıfını incelerseniz eğer CompareTo metodu içerisinde diğer nesneleri temsil eden Part tipinde bir “other” isimli parametre gelmektedir. Yapılan kontrol neticesinde o anki nesneyle, diğer nesneler arasında belirli özelliğe göre karşılaştırma yapılmakta ve karşılaştırmanın sonucu geriye int tipinde bir değer olarak döndürülmektedir.

Sıralama algoritmasının .NET açısından dönen sonucuna göre;

Negatif bir değerse, bu nesne diğer nesneden küçük
Sıfıra eşitse, bu nesne ile diğer nesne eşit
Sıfırdan büyük ise, bu nesne diğer nesneden büyük
şeklindedir.

Bu interface'den sonra Array.Sort metoduyla sıralama gerçekleştirebiliriz.

<img alt="ss1" src="https://user-images.githubusercontent.com/107070882/213446440-fadb8763-5c78-4cb4-819e-83b33702e0fa.png">
