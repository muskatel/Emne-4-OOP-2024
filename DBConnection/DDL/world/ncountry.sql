create table ncountry
(
    Country_Code       char(3)  default '' not null,
    Country_Name       char(52) default '' not null,
    Country_Population int      default 0  not null,
    Country_Capital    int                 null
);

