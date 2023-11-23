const preencherDadosPizza = (pizzaItem, item, index) => {
    pizzaItem.querySelector("img").src = item.img
    pizzaItem.querySelector("h3").innerHTML = item.name
    //pizzaItem.querySelector(".descricao").innerHTML = item.description
    pizzaItem.querySelector(".preco").innerHTML = `R$${item.price[0].toFixed(2)}`
}

catalogoJson.map((item, index) => {
    let pizzaItem = document.querySelector(".models .item").cloneNode(true);

    document.querySelector("#jogos").append(pizzaItem)

    preencherDadosPizza(pizzaItem, item, index)
})