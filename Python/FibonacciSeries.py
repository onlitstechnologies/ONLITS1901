n = int(input("Enter a number: "))
ft = st = 1
print(ft)
print(st)
for i in range(3, n+1):
    nt = ft + st
    print(nt)
    ft = st
    st = nt

# O(n-2)    =   O(n)    -   linear