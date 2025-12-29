;(function () {
    const searchInput = document.querySelector('#scp-search')
    const classSelect = document.querySelector('#scp-select') // new
    const scpCards = document.querySelectorAll('.scp-card')

    function filterCards() {
        const query = searchInput.value.toLowerCase()
        const selectedClass = classSelect.value.toUpperCase()

        scpCards.forEach((card) => {
            const title = card
                .querySelector('.scp-title')
                .textContent.toLowerCase()
            const id = card.querySelector('.scp-id').textContent.toLowerCase()
            const classification = card
                .querySelector('.scp-class')
                .textContent.toUpperCase()

            const matchesQuery = title.includes(query) || id.includes(query)
            const matchesClass =
                selectedClass === 'ALL' ||
                classification.includes(selectedClass)

            if (matchesQuery && matchesClass) {
                card.style.display = '' // show
            } else {
                card.style.display = 'none' // hide
            }
        })
    }

    // Event listeners
    searchInput.addEventListener('input', filterCards)
    classSelect.addEventListener('change', filterCards)
})()
