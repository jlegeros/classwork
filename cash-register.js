/*
  Design a cash register drawer function checkCashRegister() that accepts purchase price as the first argument (price), payment as the second argument (cash), and cash-in-drawer (cid) as the third argument.

  cid is a 2D array listing available currency.

  The checkCashRegister() function should always return an object with a status key and a change key.

  Return {status: "INSUFFICIENT_FUNDS", change: []} if cash-in-drawer is less than the change due, or if you cannot return the exact change.

  Return {status: "CLOSED", change: [...]} with cash-in-drawer as the value for the key change if it is equal to the change due.

  Otherwise, return {status: "OPEN", change: [...]}, with the change due in coins and bills, sorted in highest to lowest order, as the value of the change key.
*/

function getChange(amountOwed, name, demnomination, register, cid) {
  if (amountOwed >= demnomination) {
    if (amountOwed <= cid) {
      let unit = Math.floor(amountOwed / demnomination);
      let demValue = unit * demnomination * 100;
      amountOwed = Math.ceil(amountOwed * 100);
      amountOwed -= demValue;
      amountOwed = amountOwed / 100;
      register.change.push([name, unit * demnomination]);
    }
    else {
      amountOwed = amountOwed * 100;
      cid = cid * 100;
      amountOwed -= cid;
      amountOwed = amountOwed / 100;
      cid = cid / 100;
      register.change.push([name, cid]);
    }
  }
  return amountOwed;
}

function checkCashRegister(price, cash, cid) {
  var register = {
    status: 'OPEN',
    change: []
  };

  let amountOwed = cash - price;
  let demnomination;
  let unit;

  for (let x = cid.length - 1; x >= 0; x--) {
    switch (cid[x][0]) {
      case 'ONE HUNDRED':
        amountOwed = getChange(amountOwed, 'ONE HUNDRED', 100, register, cid[x][1]);
        break;
      case 'TWENTY':
        amountOwed = getChange(amountOwed, 'TWENTY', 20, register, cid[x][1]);
        break;
      case 'TEN':
        amountOwed = getChange(amountOwed, 'TEN', 10, register, cid[x][1]);
        break;
      case 'FIVE':
        amountOwed = getChange(amountOwed, 'FIVE', 5, register, cid[x][1]);
        break;
      case 'ONE':
        amountOwed = getChange(amountOwed, 'ONE', 1, register, cid[x][1]);
        break;
      case 'QUARTER':
        amountOwed = getChange(amountOwed, 'QUARTER', .25, register, cid[x][1]);
        break;
      case 'DIME':
        amountOwed = getChange(amountOwed, 'DIME', .1, register, cid[x][1]);
        break;
      case 'NICKLE':
        amountOwed = getChange(amountOwed, 'NICKLE', .05, register, cid[x][1]);
        break;
      case 'PENNY':
        amountOwed = getChange(amountOwed, 'PENNY', .01, register, cid[x][1]);
        break;
    }
  }

  if (amountOwed != 0) {
    register.status = "INSUFFICIENT_FUNDS";
    register.change = [];
  }

  return register;
}

console.log(checkCashRegister(19.5, 20, [["PENNY", 0.5], ["NICKEL", 0], ["DIME", 0], ["QUARTER", 0], ["ONE", 0], ["FIVE", 0], ["TEN", 0], ["TWENTY", 0], ["ONE HUNDRED", 0]]));