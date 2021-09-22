# -*- coding: utf-8 -*-
"""
Created on Tue Sep 21 23:12:10 2021

@author: javier
"""

from kanren import Relation, facts,var,run
x = var()
padrede = Relation()
facts(padrede,("Juan","Maria"),("Pablo","Juan"),("Pablo","Marcela"),("Carlos","Devora"))
P = input("nombre ")
print("es padre de ",run(3,x,padrede(P,x)))