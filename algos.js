


(function(){
  
  document.getElementById('output').value = "OUTPUT\n---------\n\n\n";
  appendOutput = (text) => {
    document.getElementById('output').value  += text;
  }
  
  
  firstOne = ()=> {
    appendOutput("result");
  }

  
  algos = {
    firstOne:firstOne
  };
  
  algos.firstOne();
}())