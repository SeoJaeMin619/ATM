# 서재민 / ATM시스템만들기

ATM의 기능을 조금 구현해봤습니다.


처음 Start씬에서 잔액과 사용자의 이름을 확인할 수 있으며


입금을 클릭하고 들어갈 시 10000과 50000의 단위로 입금할 수 있는 버튼을 만들었습니다


나가기를 누르면 처음 Start씬으로 넘어가게 되며 출금을 누를시 출금 씬으로 넘어가게 됩니다


마찬가지로 출금씬에서도 10000과 50000의 단위로 출금할 수 있게 만들었으며 나가기를 누를시 Start씬으로 넘어가게 됩니다.



---
# 회고

금액을 객체화 시키지 못했습니다
 - 객체화를 했다면 출금씬에서 금액이 수정 됐으면 Start씬과 입금씬에서 바뀐 금액이 적용이 되어야 하는데 못했습니다


출금과 입금을 각각 10000과 50000을 누를 시 값이 각각 다릅니다
 - 출금 초기값 100000에서 10000을 3번 눌러 70000으로 만든다 해도 50000을 누르면 20000이 되는 것이 아닌 초기값 100000에서

   50000이 되는 현상이 발생했습니다. 입금도 마찬가지로 이 현상이 있어 수정하려했지만 100000을 객체화 시키지 못해

   나오는 것이라 생각했습니다.

 
