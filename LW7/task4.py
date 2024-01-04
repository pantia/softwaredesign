# vartiant 33/8=1

def get_cost(owner_car, price_sparepart, price_inspection):
    total = 0
    for x in price_sparepart:
        total = total + x
    total = total / 6
    invoice = 0.7*total+0.95*price_inspection
    print("Клієнт " + owner_car + " ваша ціна до оплати становить ",invoice)
get_cost("Mykhailo Pantia", (10,20,30,40,50,60), 2000)
