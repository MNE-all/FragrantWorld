# Тема
Информационая система
Описание предметной области
---
Данный проект предназначен для автоматизации покупок у клиентов магазина одежды. 
В проекте присутствует база данных состоящая из следующих таблиц:
 - TProducts - таблица, хрянящаяя в себе данные о продуктах;
 - TProductCategories - таблица, хрянящаяя в себе данные о категориях продуктов;
 - TPickUpPoints - таблица, хрянящаяя в себе данные о пунктах выдачи;
 - TUsers - таблица, хрянящаяя в себе данные о пользователях;
 - TManufacturers - таблица, хрянящаяя в себе данные о производителях;
 - TSuppliers - таблица, хрянящаяя в себе данные о поставщиках;
 - TCarts - таблица, хрянящаяя в себе данные о корзинах пользователей;
 - TOrders - таблица, хрянящаяя в себе данные о заказах пользователей;
 - TRoles - таблица, хрянящаяя в себе данные о ролях пользователях;
 - TUnitsOfMeasurement - таблица, хрянящаяя в себе данные о единицах измерения ;

Бизнес домен
---
Продажа парфюмерии

Автор
---
Монашов Николай Егорович студент группы ИП 20-3


## Схема базы данных
```mermaid
erDiagram

    User {
        Guid Id
        string Surname
        string Name
        string Patronymic
        string Login
        string Password
        DateTime Birthday
        int RoleId
    }
    
    Role {
        int Id
        string Name
    }
    
    Cart {
        int Id
        int ClientId
        string ProductArticleNumber
        int Amount
    }
    
    PickIpPoint {
        Int Id
        string Index
        string City
        string Street
        string Number
    }

    Supplier {
        int Id
        string Name
    }

    Manufacturer {
        int Id
        string Name
    }

    ProductCategory {
        int Id
        string Name
    }

    UnitsOfMeasurement {
        int Id
        string Name
    }
     Order {
        int Number
        int ClientId
        string ProductArticle
        int Amount
        int PickUpPointId
        DateTimeOffset OrderDate
        DateTimeOffset DeliveryDate
        int code
        bool isActive
    }

    Product {
        string ArticleNumber
        string Name
        string Description
        int UnitOfMeasurementId
        decimal Price
        float CurrentDiscount
        float MaxDiscount
        int ManufacturerId
        int SupplierId
        int CategoryId
        int StorageAmount
        string ImageURL
    }

    Role ||--o{ User: is
    User ||--o{ Order: is
    User ||--o{ Cart: is
    Product ||--o{ Order: is
    Product ||--o{ Cart: is
    PickIpPoint ||--o{ Order: is

    UnitsOfMeasurement ||--o{ Product: is
    ProductCategory ||--o{ Product: is
    Manufacturer ||--o{ Product: is
    Supplier ||--o{ Product: is
