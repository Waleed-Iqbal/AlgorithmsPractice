
(() => {

  let testArrow = {

    data: "address",

    methodOld: function() {
      console.log("methodOld arugments: ", arguments);
    },

    methodArrow: () => {
      console.log("methodNew this: ", this);
    }
  };


  testArrow.methodOld();
  testArrow.methodArrow();

})();
