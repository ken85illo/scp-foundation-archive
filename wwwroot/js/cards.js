;(function () {
    const scpCards = document.querySelectorAll('.scp-card')

    scpCards.forEach((card) => {
        const id = card.querySelector('.scp-id').textContent.toLowerCase()

        card.addEventListener('click', () => {
            window.location.href = `/Home/Details/${id.slice(4)}`
        })
    })
})()
