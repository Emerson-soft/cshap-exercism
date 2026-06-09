#include "leap.h"

bool leap_year(int year)
{
  int divisionBy4 = year % 4;
  int divisionBy100 = year % 100;
  int divisionBy400 = year % 400;

  if (divisionBy4 == 0 && divisionBy100 > 0 && divisionBy400 > 0) {
    return true;
  }

  if (divisionBy4 == 0 && divisionBy100 == 0 && divisionBy400 > 0) {
    return false;
  }

  if (divisionBy4 == 0 && divisionBy100 == 0 && divisionBy400 == 0) {
    return true;
  }

  return false;
}