# FINAL-PROJECT
# AI-Powered Job Recruitment Platform

## Project Description
Bu layihə diplom işi çərçivəsində hazırlanmış **AI dəstəkli işə qəbul (Job Recruitment) veb platformasıdır**.  
Platformanın əsas məqsədi iş axtaran şəxslərlə şirkətləri bir sistem üzərindən birləşdirmək və namizədlərin bacarıqlarına uyğun vakansiyaların tövsiyə olunmasını təmin etməkdir.

Layihə **müasir RESTful API arxitekturası** əsasında qurulur və real iş platformalarında istifadə olunan texniki yanaşmaları əhatə edir.

---

## System Roles
Sistem 3 əsas istifadəçi növündən ibarətdir:

- **Candidate (Namizəd / İş axtaran)**
- **Company (Şirkət / İşəgötürən)**
- **Admin (İdarəedici)**

---

## Main Features

### Candidate
- Qeydiyyat və giriş
- Şəxsi profil yaratma
- Bacarıqlar və iş təcrübəsinin əlavə edilməsi
- GitHub, LinkedIn və digər linklərin daxil edilməsi
- CV yükləmə (PDF)
- Uyğun vakansiyaların AI əsaslı tövsiyəsi
- Vakansiyalara müraciət və statusun izlənməsi

### Company
- Şirkət profili yaratma
- Vakansiya yerləşdirmə
- Namizədlərin siyahısını və uyğunluq faizlərini görmə
- Müraciətləri qəbul və ya rədd etmə

### Admin
- İstifadəçilərin idarə olunması
- Şirkətlərin təsdiqlənməsi
- Sistemə ümumi nəzarət

---

## AI-Supported Matching Logic
Sistem namizədin bacarıqları və iş təcrübəsini vakansiyanın tələbləri ilə müqayisə edərək **uyğunluq faizi (match score)** hesablayır.  
Bu mexanizm işə qəbul prosesini daha səmərəli və sürətli edir.

---

## Technologies Used

### Backend
- ASP.NET Core Web API
- Entity Framework Core
- JWT Authentication
- Role-based Authorization
- Background Services
- Logging
- Email Notifications
- Docker (basic)

### Frontend
- React (UI Template based)
- HTML / CSS / JavaScript

### Database
- SQL Server (Code First)

---

## Project Architecture
