create table ncity
(
    City_ID          int      default 0  not null,
    City_Name        char(35) default '' not null,
    City_CountryCode char(3)  default '' not null,
    City_Population  int      default 0  not null
);

